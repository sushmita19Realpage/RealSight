namespace DynaQ.Backend.Models
{
    public class TrackingEvent
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string EventType { get; set; } = string.Empty;
        public string EventId { get; set; } = string.Empty;
        public string ProjectId { get; set; } = string.Empty;
        public string? AdId { get; set; }
        public string? SurveyId { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public Dictionary<string, object>? Metadata { get; set; }
        public string? UserAgent { get; set; }
        public string? IpAddress { get; set; }
        public string? SessionId { get; set; }
    }

    public class TrackingEventRequest
    {
        public string EventType { get; set; } = string.Empty;
        public string EventId { get; set; } = string.Empty;
        public string ProjectId { get; set; } = string.Empty;
        public string? AdId { get; set; }
        public string? SurveyId { get; set; }
        public Dictionary<string, object>? Metadata { get; set; }
        public string? SessionId { get; set; }
    }

    public class TrackingEventResponse
    {
        public bool Success { get; set; }
        public string? Error { get; set; }
        public string EventId { get; set; } = string.Empty;
    }
} 