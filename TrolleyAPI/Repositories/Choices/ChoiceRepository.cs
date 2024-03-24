using TrolleyAPI.DataLayer;
using TrolleyAPI.DataLayer.DTO;

namespace TrolleyAPI.Repositories.Choices
{
	public class ChoiceRepository : IChoiceRepository
	{
		private ApplicationContext dataBase;

		public ChoiceRepository(ApplicationContext dataBase)
		{
			this.dataBase = dataBase;
		}

		public void AddChoice(Choice choice)
		{
			dataBase.Choices.Add(choice);
			dataBase.SaveChanges();
		}

		public IEnumerable<Choice> GetChoices()
		{
			return dataBase.Choices.ToList();
		}

		public IEnumerable<Choice> GetChoices(int level)
		{
			return dataBase.Choices.Where(C => C.Level.Equals(level));
		}
	}
}
