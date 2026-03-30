import { Injectable } from '@angular/core';
import {
    HttpRequest,
    HttpHandler,
    HttpEvent,
    HttpInterceptor,
    HttpErrorResponse
} from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, finalize } from 'rxjs/operators';
import { LoadingService } from '../services/loading.service';
import { ErrorHandlerService } from '../services/error-handler.service';

@Injectable()
export class ApiInterceptor implements HttpInterceptor {
    constructor(
        private loadingService: LoadingService,
        private errorHandler: ErrorHandlerService
    ) { }

    intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
        this.loadingService.show();

        return next.handle(request).pipe(
            catchError((error: HttpErrorResponse) => {
                let errorMsg = 'An unknown network error occurred!';
                if (error.error instanceof ErrorEvent) {
                    errorMsg = `Client Error: ${error.error.message}`;
                } else {
                    errorMsg = `Server Error [${error.status}]: ${error.message || 'Unknown server failure.'}`;
                }

                this.errorHandler.handleError(errorMsg);
                return throwError(() => error);
            }),
            finalize(() => {
                this.loadingService.hide();
            })
        );
    }
}
