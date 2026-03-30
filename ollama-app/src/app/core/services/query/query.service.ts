import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, throwError } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { QueryRequest, QueryApiResponse, QueryHistoryItem } from '../../models/query.model';

@Injectable({
    providedIn: 'root'
})
export class QueryService {
    private readonly STORAGE_KEY = 'query_history';
    private historySubject = new BehaviorSubject<QueryHistoryItem[]>([]);
    public history$ = this.historySubject.asObservable();

    constructor(private http: HttpClient) {
        this.loadHistory();
    }

    private loadHistory() {
        const stored = localStorage.getItem(this.STORAGE_KEY);
        if (stored) {
            try {
                const parsed = JSON.parse(stored);
                if (Array.isArray(parsed)) {
                    this.historySubject.next(parsed);
                }
            } catch (e) {
                console.error('Failed to parse query history from local storage', e);
            }
        }
    }

    executeQuery(request: QueryRequest): Observable<QueryApiResponse> {
        return this.http.post<QueryApiResponse>(
            'https://localhost:7113/api/query',
            request
        ).pipe(
            tap(() => this.addToHistory(request.query)),
            catchError(this.handleError)
        );
    }

    private handleError(error: HttpErrorResponse) {
        let errorMessage = 'An unknown error occurred!';
        if (error.error instanceof ErrorEvent) {
            errorMessage = `Error: ${error.error.message}`;
            console.error('Client-side query service error:', errorMessage);
        } else {
            errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
            console.error('Server-side query service error:', errorMessage);
        }
        return throwError(() => new Error('Failed to execute query. Please try again later.'));
    }

    private addToHistory(query: string) {
        const currentHistory = this.historySubject.value;
        const filteredHistory = currentHistory.filter(h => h.query.toLowerCase() !== query.toLowerCase());
        const newHistory = [{ query, timestamp: new Date() }, ...filteredHistory];
        const trimmedHistory = newHistory.slice(0, 10);

        this.historySubject.next(trimmedHistory);
        localStorage.setItem(this.STORAGE_KEY, JSON.stringify(trimmedHistory));
    }

    clearHistory() {
        this.historySubject.next([]);
        localStorage.removeItem(this.STORAGE_KEY);
    }
}
