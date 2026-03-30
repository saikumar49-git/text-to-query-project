import { Component } from '@angular/core';
import { Subject, Observable, of } from 'rxjs';
import { catchError, switchMap } from 'rxjs/operators';
import { QueryService } from '../../../../core/services/query/query.service';
import { LoadingService } from '../../../../core/services/loading.service';
import { QueryRequest, QueryApiResponse } from '../../../../core/models/query.model';

@Component({
  selector: 'app-dashboard-page',
  templateUrl: './dashboard-page.component.html',
  styleUrls: ['./dashboard-page.component.scss']
})
export class DashboardPageComponent {
  private searchSubject = new Subject<string>();

  // Expose fully reactive endpoints directly to the template stream
  history$ = this.queryService.history$;
  isLoading$ = this.loadingService.isLoading$;

  results$: Observable<QueryApiResponse | null> = this.searchSubject.pipe(
    switchMap(queryText => {
      const request: QueryRequest = { query: queryText };
      return this.queryService.executeQuery(request).pipe(
        catchError(() => of(null)) // Return null on error; interceptor manages global error toast
      );
    })
  );

  constructor(
    private queryService: QueryService,
    private loadingService: LoadingService
  ) { }

  onSearchStarted(queryText: string) {
    if (queryText && queryText.trim()) {
      this.searchSubject.next(queryText);
    }
  }
}
