import React, { useState } from 'react';

const PaymentFields = () => {
  const [selectedMethod, setSelectedMethod] = useState('creditCard');

  const handleRadioChange = (event) => {
    setSelectedMethod(event.target.value);
  };

  return (
    <div className="container mt-4">
      <div className="card p-4">
        <div className="row align-items-center mb-3">
          <div className="col-md-12">
            <h5 className="mb-1">Payment Method</h5>
            <div className='d-flex' style={{justifyContent: 'space-between'}}>
              <p className="small" style={{color: '#90A3BF'}}>Please enter your payment method</p>
              <small className="small" style={{color: '#90A3BF'}}>Step 3 of 4</small>
            </div>
          </div>
        </div>

        <div
          className="rounded p-4"
          style={{ backgroundColor: '#F6F7F9', border: '1px solid #ddd' }}
        >
          <div className="form-check mb-3">
            <div className='d-flex justify-content-between' style={{gap: '10px'}}>
              <div>
                <img src='/src/assets/mark.png' />
                <label className="form-check-label ml-2" htmlFor="creditCard">
                 Credit Card
                </label>
              </div>
              <img
                src="/src/assets/Visa.png"
                alt="Visa & Mastercard"
                style={{ width: '100px' }}
              />
            </div>
          </div>

          {selectedMethod === 'creditCard' && (
            <form>
              <div className="row g-3">
                <div className="col-md-6">
                  <label htmlFor="cardNumber" className="form-label">
                    Card Number
                  </label>
                  <input
                    type="text"
                    className="form-control"
                    id="cardNumber"
                    placeholder="Card number"
                  />
                </div>
                <div className="col-md-6">
                  <label htmlFor="expirationDate" className="form-label">
                    Expiration Date
                  </label>
                  <input
                    type="text"
                    className="form-control"
                    id="expirationDate"
                    placeholder="DD/MM/YY"
                  />
                </div>
                <div className="col-md-6">
                  <label htmlFor="cardHolder" className="form-label">
                    Card Holder
                  </label>
                  <input
                    type="text"
                    className="form-control"
                    id="cardHolder"
                    placeholder="Card holder"
                  />
                </div>
                <div className="col-md-6">
                  <label htmlFor="cvc" className="form-label">
                    CVC
                  </label>
                  <input
                    type="text"
                    className="form-control"
                    id="cvc"
                    placeholder="CVC"
                  />
                </div>
              </div>
            </form>
          )}
        </div>
      </div>
    </div>
  );
};

export default PaymentFields;