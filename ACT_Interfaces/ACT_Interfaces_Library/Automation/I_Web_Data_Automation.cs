using ACT.Core.Interfaces.Common;

namespace ACT.Core.Interfaces.Automation
{

	/// <summary>
	///     Configure Web Data Specific Automation
	/// </summary>
	public interface I_Web_Data_Automation
	{

		public Dictionary<string, string> DownloadedDocuments { get; }

		public bool DeleteAutomation (Guid ID);

		public int ManualAutomationExport (Guid ID);

		public bool NeedsExecution ();

		public Guid SetupAutomation (string BaseURL, string Name, int Interval, bool EncryptData, DateTime Start,
			DateTime End, bool CacheDataUnlessChanged, bool FollowLinks, bool LinksMustBeBelowBaseURL);

		public I_ResultExpanded TestAutomation (Guid ID);

		public bool UpdateAutomation (string BaseURL, string Name, int Interval, bool EncryptData, DateTime Start,
			DateTime End, bool CacheDataUnlessChanged, bool FollowLinks, bool LinksMustBeBelowBaseURL);

	}
}