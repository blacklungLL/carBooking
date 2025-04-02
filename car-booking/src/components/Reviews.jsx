import React from 'react';

const Reviews = ({ reviews }) => {
    const formatDate = (dateString) => {
        const date = new Date(dateString);
        return date.toLocaleDateString('en-US', {
          year: 'numeric',
          month: '2-digit',
          day: '2-digit',
        });
    };

    return (
        <div className='col-12 p-3'>
            <div className='p-3 reviews'>
                <h4 className='m-3 mb-4'>Reviews <background-blue>{reviews.length}</background-blue></h4>
                {reviews.map(review =>(
                    <div key={review.id} className='review row'>
                        <div className='review-img col-1 p-0'>
                            <img src={review.img} className="reviewer-img" alt="lol"/>
                        </div>
                        <div className='col-11 row p-0'>
                            <div className='col-10 p-0'>
                                <h5 className='reviewer-name'>{review.name}</h5>
                                <h6 className='reviewer-post'>{review.position}</h6>
                            </div>
                            <div className='col-2 p-0 data-stars'>
                                <p>{formatDate(review.date)}</p>
                                <i className="fas fa-star"></i>
                                <i className="fas fa-star"></i>
                                <i className="fas fa-star"></i>
                                <i className="fas fa-star"></i>
                                <i className="fa-regular fa-star"></i>
                            </div>
                            <p className='mt-3 review-text'>{review.text}</p>
                        </div>
                    </div>
                ))}
                <div className='col-2 offset-5 d-flex align-items-center'>
                    <h4 className='highlited-gray'>Show All</h4>
                    <i className="fa-solid fa-arrow-down ml-2 highlited-gray"></i>
                </div>
            </div> 
        </div>
    );
}

export default Reviews;