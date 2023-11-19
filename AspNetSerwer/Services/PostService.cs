using AspNetSerwer.Data;
using AspNetSerwer.Data.UnitOfWork;

namespace AspNetSerwer.Services
{
    public class ProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Post> _postRepository;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _postRepository = _unitOfWork.GetRepository<Post>();
        }

        public void CreatePost(Post post)
        {
            // Perform business logic and repository operations using _postRepository...
            _postRepository.Add(post);

            _unitOfWork.Commit();
        }
    }
}
