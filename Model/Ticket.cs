using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Model
{
    /// <summary>
    /// Represents a Ticket entity stored in the MongoDB database. 
    /// This class defines the structure and fields of the ticket document.
    /// </summary>
    public class Ticket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonIgnore]
        public string? TicketId { get; set; }

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
        [BsonRepresentation(BsonType.String)]
        public Status Status { get; private set; }

        [BsonElement("priority")]
        [BsonRepresentation(BsonType.String)]
        public Priority Priority { get; private set; }

        [BsonElement("is_resolved")]
        public bool IsResolved { get; private set; }

        [BsonElement("is_escalated")]
        public bool IsEscalated { get; private set; }

        [BsonElement("deadline")]
        public DateTime Deadline { get; private set; }

        [BsonElement("type_of_incident")]
        [BsonRepresentation(BsonType.String)] // making sure that the role is in text in db and not just the numerical value of enum
        public IncidentType IncidentType { get; private set; }

        [BsonElement("creation_date")]
        public DateTime CreationDate { get; private set; }
        [BsonIgnore]
        [JsonIgnore]
        public string? ReportingEmployeeFirstName { get; set; }
        [BsonIgnore]
        [JsonIgnore]
        public string? ReportingEmployeeLastName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ticket"/> class with the specified details.
        /// </summary>
        /// <param name="reportingUser">The ID of the user who reported the ticket.</param>
        /// <param name="serviceDeskUser">The ID of the service desk user assigned to the ticket.</param>
        /// <param name="title">The title of the ticket.</param>
        /// <param name="description">The description of the ticket.</param>
        /// <param name="status">The current status of the ticket.</param>
        /// <param name="priority">The priority level of the ticket.</param>
        /// <param name="isResolved">Indicates if the ticket is resolved.</param>
        /// <param name="isEscalated">Indicates if the ticket has been escalated.</param>
        /// <param name="deadline">The deadline for resolving the ticket.</param>
        /// <param name="incidentType">The type of incident associated with the ticket.</param>
        /// <param name="creationDate">The creation date of the ticket.</param>
        /// <param name="ticketId">The unique identifier of the ticket (optional).</param>
        public Ticket(string reportingUser, string serviceDeskUser, string title, string description, Status status, Priority priority, bool isResolved, bool isEscalated, DateTime deadline, IncidentType incidentType, DateTime creationDate, string? ticketId = null)
        {
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
            TicketId = ticketId;
        }
    }
}