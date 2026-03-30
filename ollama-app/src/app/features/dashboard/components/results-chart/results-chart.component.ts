import { Component, Input, OnChanges, SimpleChanges, ViewChild } from '@angular/core';
import { ChartConfiguration, ChartData, ChartType } from 'chart.js';
import { BaseChartDirective } from 'ng2-charts';

/** Only these fields will be plotted in the chart */
const VISIBLE_FIELDS = [
  'NoOfFloors',
  'PermitNumber',
  'AuthorizationStatus',
  'CreatedOn',
  'ApplicationNumber',
  'PolicyNumber',
  'ProjectTitle'
];

@Component({
  selector: 'app-results-chart',
  templateUrl: './results-chart.component.html',
  styleUrls: ['./results-chart.component.scss']
})
export class ResultsChartComponent implements OnChanges {
  @Input() data: any[] = [];
  @ViewChild(BaseChartDirective) chart!: BaseChartDirective;

  public chartType: ChartType = 'bar';
  public labelColumn: string = '';
  public valueColumn: string = '';
  public numericColumns: string[] = [];

  public chartOptions: ChartConfiguration['options'] = {
    responsive: true,
    maintainAspectRatio: false,
    plugins: {
      legend: {
        display: true,
        position: 'bottom'
      },
      tooltip: {
        callbacks: {
          label: (ctx) => ` ${ctx.dataset.label}: ${ctx.parsed.y ?? ctx.parsed}`
        }
      }
    },
    scales: {
      x: { ticks: { maxRotation: 45 } }
    }
  };

  public chartData: ChartData<any> = {
    labels: [],
    datasets: []
  };

  private readonly COLORS = [
    'rgba(99,102,241,0.8)',
    'rgba(236,72,153,0.8)',
    'rgba(16,185,129,0.8)',
    'rgba(245,158,11,0.8)',
    'rgba(59,130,246,0.8)',
    'rgba(239,68,68,0.8)',
    'rgba(139,92,246,0.8)',
    'rgba(14,165,233,0.8)',
  ];

  ngOnChanges(changes: SimpleChanges): void {
    if (changes['data'] && this.data && this.data.length > 0) {
      this.detectColumns();
      this.updateChartData();
    }
  }

  private detectColumns() {
    if (!this.data.length) return;
    const keys = Object.keys(this.data[0]);

    // Only work within the whitelisted fields
    const visibleKeys = VISIBLE_FIELDS.filter(f => keys.includes(f));

    // Find string-like columns for labels (prefer short string values)
    const stringCols = visibleKeys.filter(k => {
      const val = this.data[0][k];
      return typeof val === 'string' && !val.match(/^\d{4}-\d{2}-\d{2}T/);
    });

    // Find numeric columns for values
    this.numericColumns = visibleKeys.filter(k => typeof this.data[0][k] === 'number');

    // Prefer columns with the word 'Status', 'Title', 'Number', 'Name', 'Permit' for label
    const preferredLabelCols = stringCols.filter(k =>
      /status|title|name|number|type|permit/i.test(k)
    );

    this.labelColumn = preferredLabelCols[0] || stringCols[0] || visibleKeys[0];

    // Default value column: first numeric column
    this.valueColumn = this.numericColumns[0] || '';
  }

  private updateChartData() {
    if (!this.data.length || !this.labelColumn) return;

    const labels = this.data.map(row => {
      const val = row[this.labelColumn];
      return val != null ? String(val) : '—';
    });

    // If there are numeric columns, show one dataset per column (max 6)
    const colsToShow = this.numericColumns.slice(0, 6);

    let datasets: any[];

    if (colsToShow.length > 0) {
      datasets = colsToShow.map((col, i) => ({
        data: this.data.map(row => row[col] ?? 0),
        label: this.formatHeader(col),
        backgroundColor: this.COLORS[i % this.COLORS.length],
        borderColor: this.COLORS[i % this.COLORS.length].replace('0.8', '1'),
        borderWidth: 2,
        borderRadius: 4
      }));
    } else {
      // No numeric columns — show count grouping by label
      const counts: Record<string, number> = {};
      this.data.forEach(row => {
        const k = String(row[this.labelColumn] ?? '—');
        counts[k] = (counts[k] || 0) + 1;
      });
      const uniqueLabels = Object.keys(counts);
      datasets = [{
        data: uniqueLabels.map(k => counts[k]),
        label: 'Count',
        backgroundColor: this.COLORS,
        borderWidth: 2,
        borderRadius: 4
      }];
      this.chartData = { labels: uniqueLabels, datasets };
      this.refreshChart();
      return;
    }

    this.chartData = { labels, datasets };
    this.refreshChart();
  }

  private refreshChart() {
    this.chartData = { ...this.chartData };
    if (this.chart) {
      this.chart.update();
    }
  }

  setChartType(val: string) {
    this.chartType = val as ChartType;
    // Pie/doughnut don't support scales
    if (this.chartOptions?.scales) {
      (this.chartOptions as any).scales = (val === 'pie' || val === 'doughnut')
        ? undefined
        : { x: { ticks: { maxRotation: 45 } } };
    }
    if (this.chart) {
      this.chart.update();
    }
  }

  formatHeader(key: string): string {
    return key.replace(/([A-Z])/g, ' $1').replace(/^./, s => s.toUpperCase()).trim();
  }
}
