// Generated by https://quicktype.io

export interface UserTasks {
    totalTasksCount: number;
    tasks:           Task[];
}

interface Task {
    id:          number;
    title:       string;
    description: string;
    dueDate:     string;
    priority:    string;
    remarks:     string;
}