import { Component, Input, OnChanges, SimpleChanges, ViewChild, AfterViewInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';

/** Only these fields will be shown in the table and chart */
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
  selector: 'app-results-table',
  templateUrl: './results-table.component.html',
  styleUrls: ['./results-table.component.scss']
})
export class ResultsTableComponent implements OnChanges, AfterViewInit {
  @Input() data: any[] = [];

  displayedColumns: string[] = [];
  dataSource: MatTableDataSource<any> = new MatTableDataSource();

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  ngOnChanges(changes: SimpleChanges): void {
    if (changes['data'] && this.data && this.data.length > 0) {
      // Only show whitelisted columns that actually exist in the data
      const available = Object.keys(this.data[0]);
      this.displayedColumns = VISIBLE_FIELDS.filter(f => available.includes(f));
      this.dataSource.data = this.data;
    } else {
      this.displayedColumns = [];
      this.dataSource.data = [];
    }
  }

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  /** Format cell values for display */
  formatValue(value: any): string {
    if (value === null || value === undefined) return '—';
    if (typeof value === 'boolean') return value ? 'Yes' : 'No';
    if (typeof value === 'string' && value.match(/^\d{4}-\d{2}-\d{2}T/)) {
      return new Date(value).toLocaleDateString('en-IN', {
        day: '2-digit', month: 'short', year: 'numeric',
        hour: '2-digit', minute: '2-digit'
      });
    }
    return String(value);
  }

  /** Format column header from camelCase/PascalCase to readable label */
  formatHeader(key: string): string {
    return key.replace(/([A-Z])/g, ' $1').replace(/^./, s => s.toUpperCase()).trim();
  }
}
