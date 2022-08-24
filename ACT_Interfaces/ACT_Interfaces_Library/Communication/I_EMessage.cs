namespace ACT.Core.Interfaces.Communication
{

    public interface I_EDataRecord
    {
        byte[] UniqueRecordId { get; }
        byte[] RequestHistory { get; }
        byte[] OwnerId { get; }
        byte[] RawData { get; }
    }

    public interface I_EDataLog
    {
        byte[] UniqueRecordId { get; }
        byte[] OwnerId { get; }
        byte[] RequesterId { get; }
        bool RequestResult { get; }
        byte[] RequestResultReason { get; }


    }


    public interface I_EMessageData
    {
        /// <summary>
        /// Unique Message ID
        /// </summary>
        byte[] UniqueMessageId { get; }

        /// <summary>
        /// Global Senders ID
        /// </summary>
        byte[] SenderId { get; }

        /// <summary>
        /// Global Recievers ID
        /// </summary>
        byte[] ReciverId { get; }

        /// <summary>
        /// Specific Message Subject
        /// </summary>
        byte[] SubjectText { get; }

        /// <summary>
        /// Specific Message Body
        /// </summary>
        byte[] BodyText { get; }

        /// <summary>
        /// Specific Touch Chain For This Message (Includes Complete History)
        /// </summary>
        byte[] TouchChain { get; }

        /// <summary>
        /// Specific Meta Data
        /// </summary>
        bool[] MetaData { get; }


    }
}
