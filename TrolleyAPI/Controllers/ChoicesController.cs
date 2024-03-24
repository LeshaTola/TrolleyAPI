using Microsoft.AspNetCore.Mvc;
using TrolleyAPI.DataLayer.DTO;
using TrolleyAPI.Repositories.Choices;

namespace TrolleyAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ChoicesController : ControllerBase
	{
		private IChoiceRepository choiceRepository;

		public ChoicesController(IChoiceRepository choiceRepository)
		{
			this.choiceRepository = choiceRepository;
		}

		[HttpGet]
		public IEnumerable<Choice> Get()
		{
			return choiceRepository.GetChoices();
		}

		[HttpGet("{level}")]
		public IEnumerable<Choice> Get(int level)
		{
			return choiceRepository.GetChoices(level);
		}

		[HttpPost]
		public void Post(Choice choice)
		{
			choiceRepository.AddChoice(choice);
		}
	}
}
