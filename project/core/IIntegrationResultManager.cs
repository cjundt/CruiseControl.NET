using ThoughtWorks.CruiseControl.Remote;

namespace ThoughtWorks.CruiseControl.Core
{
	public interface IIntegrationResultManager
	{
		IIntegrationResult LastIntegrationResult { get; }

		IIntegrationResult StartNewIntegration(BuildCondition buildCondition);
		void FinishIntegration();
	}
}