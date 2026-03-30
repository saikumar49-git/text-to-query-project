import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SharedModule } from '../../shared/shared.module';
import { NgChartsModule } from 'ng2-charts';
import { MatButtonToggleModule } from '@angular/material/button-toggle';

import { DashboardRoutingModule } from './dashboard-routing.module';
import { DashboardPageComponent } from './pages/dashboard-page/dashboard-page.component';
import { SearchChatComponent } from './components/search-chat/search-chat.component';
import { ResultsTableComponent } from './components/results-table/results-table.component';
import { ResultsChartComponent } from './components/results-chart/results-chart.component';

@NgModule({
  declarations: [
    DashboardPageComponent,
    SearchChatComponent,
    ResultsTableComponent,
    ResultsChartComponent
  ],
  imports: [
    CommonModule,
    DashboardRoutingModule,
    SharedModule,
    NgChartsModule,
    MatButtonToggleModule
  ]
})
export class DashboardModule { }
