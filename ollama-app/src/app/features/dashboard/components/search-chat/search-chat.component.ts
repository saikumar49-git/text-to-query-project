import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { QueryHistoryItem } from '../../../../core/models/query.model';

@Component({
  selector: 'app-search-chat',
  templateUrl: './search-chat.component.html',
  styleUrls: ['./search-chat.component.scss']
})
export class SearchChatComponent {
  @Input() isLoading = false;
  @Input() history: QueryHistoryItem[] = [];
  @Output() searchSubmitted = new EventEmitter<string>();

  searchControl = new FormControl('', [Validators.required, Validators.minLength(2)]);

  onSubmit() {
    if (this.searchControl.valid && !this.isLoading) {
      this.searchSubmitted.emit(this.searchControl.value as string);
    }
  }

  onHistorySelect(queryText: string) {
    this.searchControl.setValue(queryText);
    this.onSubmit();
  }

  onKeyDown(event: KeyboardEvent) {
    if (event.key === 'Enter') {
      event.preventDefault();
      this.onSubmit();
    }
  }
}
