import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';

@Injectable({
    providedIn: 'root'
})
export class ErrorHandlerService {
    constructor(private snackBar: MatSnackBar) { }

    public handleError(message: string, action: string = 'Close', duration: number = 5000) {
        this.snackBar.open(message, action, {
            duration: duration,
            panelClass: ['error-snackbar'],
            horizontalPosition: 'center',
            verticalPosition: 'top'
        });
    }
}
