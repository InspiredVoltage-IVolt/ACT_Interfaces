namespace ACT.Core.Interfaces.Communication
{

    public interface I_EDataRecord
    {
        byte[] uniqueRecordID { get; }
        byte[] requestHistory { get; }
        byte[] ownerID { get; }
        byte[] rawData { get; }
    }

    public interface I_EDataLog
    {
        byte[] uniqueRecordID { get; }
        byte[] ownerID { get; }
        byte[] requesterID { get; }
        bool requestResult { get; }
        byte[] requestResultReason { get; }


    }


    public interface I_EMessageData
    {
        /// <summary>
        /// Unique Message ID
        /// </summary>
        byte[] uniqueMessageID { get; }

        /// <summary>
        /// Global Senders ID
        /// </summary>
        byte[] senderID { get; }

        /// <summary>
        /// Global Recievers ID
        /// </summary>
        byte[] reciverID { get; }

        /// <summary>
        /// Specific Message Subject
        /// </summary>
        byte[] subjectText { get; }

        /// <summary>
        /// Specific Message Body
        /// </summary>
        byte[] bodyText { get; }

        /// <summary>
        /// Specific Touch Chain For This Message (Includes Complete History)
        /// </summary>
        byte[] touchChain { get; }

        /// <summary>
        /// Specific Meta Data
        /// </summary>
        bool[] metaData { get; }


    }
}
