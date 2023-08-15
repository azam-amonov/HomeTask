namespace HomeWork_24.N22_HT2;

public class ReviewList<TReview>: IReviewList<IReview>
{
    private readonly List<IReview> _reviews;
    
    public ReviewList()
    {
      _reviews = new List<IReview>();  
    }
    
    public void Add(IReview review)
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

    public void Remove(IReview review)
    {
        var removeReview = _reviews.FirstOrDefault(r => r.Id == review.Id);
        if (removeReview is not null) _reviews.Remove(removeReview);
    }

    public IReview? GetReview(int id)
    {
        var getReviewById =  _reviews.FirstOrDefault(r => r.Id == id);
        if (getReviewById is not null) return getReviewById;
        return null;
    }

    public IReview? GetReview(string message)
    {
       var getReviewByMessage = _reviews.FirstOrDefault(r => r.Message == message);
       if (getReviewByMessage is not null) return getReviewByMessage;
       return null;
    }

    public string GetOverallReviews()
    {
        if(_reviews.Count == 0)
            return "Be the first to leave a review for this product";
        
        if (_reviews.All(x => x.Star == 5))
            return "Great news! All reviews for this product are 5-star ratings.";
        
        if (_reviews.Any(x => x.Star == 1))
            return _reviews.FirstOrDefault(r => r.Star == 1).Message;
        
        return "Sorry, there is no any review for this product";
    }
}