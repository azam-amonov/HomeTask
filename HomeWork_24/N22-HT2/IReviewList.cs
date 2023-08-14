using System.Net.Sockets;

namespace HomeWork_24.N22_HT2;

public interface IReviewList<in TReview> where TReview: IReview
{
    public void Add(TReview review);
    public void Update(int id, int star, string message);
    public void Remove(int id);
    public void Remove(TReview review);
    public IReview? GetReview(int id);
    public IReview? GetReview(string message);
    public string GetOverallReviews();
    

}