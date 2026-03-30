export interface QueryRequest {
    query: string;
}

export interface QueryApiResponse {
    sqlQuery: string;
    data: any[];
}

export interface QueryResultItem {
    id: number;
    label: string;
    value: number;
    category: string;
}

export interface QueryHistoryItem {
    query: string;
    timestamp: Date;
}
