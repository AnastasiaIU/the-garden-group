﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public class Ticket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string TicketId { get; private set; }
        [BsonElement("reporting_user")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ReportingUser { get; private set; }
        [BsonElement("service_desk_user")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ServiceDeskUser { get; private set; }
        [BsonElement("title")]
        public string Title { get; private set; }
        [BsonElement("description")]
        public string Description { get; private set; }
        [BsonElement("status")]
        public Status Status { get; private set; }
        [BsonElement("priority")]
        public Priority Priority { get; private set; }
        [BsonElement("is_resolved")]
        public bool IsResolved { get; private set; }
        [BsonElement("is_escalated")]
        public bool IsEscalated { get; private set; }
        [BsonElement("deadline")]
        public DateTime Deadline { get; private set; }
        [BsonElement("type_of_incident")]
        public IncidentType IncidentType { get; private set; }
        [BsonElement("creation_date")]
        public DateTime CreationDate { get; private set; }
        public string ReportingEmployeeFirstName { get; set; }
        public string ReportingEmployeeLastName { get; set; }

        public Ticket(string ticketId, string reportingUser, string serviceDeskUser, string title, string description, Status status, Priority priority, bool isResolved, bool isEscalated, DateTime deadline, IncidentType incidentType, DateTime creationDate)
        {
            TicketId = ticketId;
            ReportingUser = reportingUser;
            ServiceDeskUser = serviceDeskUser;
            Title = title;
            Description = description;
            Status = status;
            Priority = priority;
            IsResolved = isResolved;
            IsEscalated = isEscalated;
            Deadline = deadline;
            IncidentType = incidentType;
            CreationDate = creationDate;
        }
    }
}