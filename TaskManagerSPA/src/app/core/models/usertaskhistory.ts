// Generated by https://quicktype.io

export interface UserTasksHistory {
    totalTasksHistoryCount: number;
    tasksHistory:           TaskHistory[];
}

interface TaskHistory {
    taskId:      number;
    title:       string;
    description: string;
    dueDate:     string;
    completed:   string;
    remarks:     string;
}
