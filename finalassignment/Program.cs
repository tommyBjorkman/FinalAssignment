using finalassignment.Services;

StatusService statusService = new();
await statusService.CreateStatusTypesAsync();