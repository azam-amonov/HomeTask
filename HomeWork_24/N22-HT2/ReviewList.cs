namespace HomeWork_24.N22_HT2;

public class ReviewList: IReviewList<Review>
{
    private readonly List<Review> _reviews;
    
    public ReviewList()
    {
      _reviews = new List<Review>();  
    }
    
    public void Add(Review review)
    {
        _reviews.Add(review);
    }

    public void Update(int id, int star, string message)
    {
        var reviewToUpdate = _reviews.FirstOrDefault(x => x.Id == id);
        if (reviewToUpdate is not null)
        {
            reviewToUpdate.Star = star;
            reviewToUpdate.Message = message;
        }

    }

    public void Remove(int id)
    {
        var reviewToRemoveById = _reviews.FirstOrDefault(x => x.Id == id);
        if (reviewToRemoveById != null) _reviews.Remove(reviewToRemoveById);
    }

    public void Remove(Review review)
    {
        var removeReview = _reviews.FirstOrDefault(r => r.Id == review.Id);
        if (removeReview is not null) _reviews.Remove(removeReview);
    }

    public Review? GetReview(int id)
    {
        var getReviewById =  _reviews.FirstOrDefault(r => r.Id == id);
        if (getReviewById is not null) return getReviewById;
        return null;
    }

    public Review? GetReview(string message)
    {
       var getReviewByMessage = _reviews.FirstOrDefault(r => r.Message == message);
       if (getReviewByMessage is not null) return getReviewByMessage;
       return null;
    }

    public void GetOverallReviews()
    {
        throw new NotImplementedException();
    }
}