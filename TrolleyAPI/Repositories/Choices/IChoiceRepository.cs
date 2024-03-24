using TrolleyAPI.DataLayer.DTO;

namespace TrolleyAPI.Repositories.Choices
{
	public interface IChoiceRepository
	{
		public IEnumerable<Choice> GetChoices();
		public IEnumerable<Choice> GetChoices(int level);
		public void AddChoice(Choice choice);
	}
}
