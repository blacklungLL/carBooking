import React from 'react';

const Reviews = () => {
    return (
        <div className='col-12 p-3'>
            <div className='p-3 reviews'>
                <h4 className='m-3 mb-4'>Reviews <background-blue>13</background-blue></h4>
                <div className='review row'>
                    <div className='review-img col-1 p-0'>
                        <img src="/src/assets/profile.png" className="reviewer-img" alt="lol"/>
                    </div>
                    <div className='col-11 row p-0'>
                        <div className='col-10 p-0'>
                            <h5 className='reviewer-name'>Alex Stanton</h5>
                            <h6 className='reviewer-post'>CEO at Bukalapak</h6>
                        </div>
                        <div className='col-2 p-0 data-stars'>
                            <p>21 July 2022</p>
                            <i className="fas fa-star"></i>
                            <i className="fas fa-star"></i>
                            <i className="fas fa-star"></i>
                            <i className="fas fa-star"></i>
                            <i className="fa-regular fa-star"></i>
                        </div>
                        <p className='mt-3 review-text'>We are very happy with the service from the MORENT App. Morent has a low price and also a large variety of cars with good and comfortable facilities. In addition, the service provided by the officers is also very friendly and very polite.</p>
                    </div>
                </div>
                <div className='review row'>
                    <div className='review-img col-1 p-0'>
                        <img src="/src/assets/woman.jpg" className="reviewer-img" alt="lol"/>
                    </div>
                    <div className='col-11 row p-0'>
                        <div className='col-10 p-0'>
                            <h5 className='reviewer-name'>Skylar Dias</h5>
                            <h6 className='reviewer-post'>CEO at Amazon</h6>
                        </div>
                        <div className='col-2 p-0 data-stars'>
                            <p>20 July 2022</p>
                            <i className="fas fa-star"></i>
                            <i className="fas fa-star"></i>
                            <i className="fas fa-star"></i>
                            <i className="fas fa-star"></i>
                            <i className="fa-regular fa-star"></i>
                        </div>
                        <p className='mt-3 review-text'>We are greatly helped by the services of the MORENT Application. Morent has low prices and also a wide variety of cars with good and comfortable facilities. In addition, the service provided by the officers is also very friendly and very polite.</p>
                    </div>
                </div>
                <div className='col-2 offset-5 d-flex align-items-center'>
                    <h4 className='highlited-gray'>Show All</h4>
                    <i className="fa-solid fa-arrow-down ml-2 highlited-gray"></i>
                </div>
            </div> 
        </div>
    );
}

export default Reviews;