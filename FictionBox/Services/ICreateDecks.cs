namespace FictionBox.Core.Services
{
	public interface ICreateDecks
	{
		void loadDecksFromResources();
		void loadDecksFromDB();
	}
}
