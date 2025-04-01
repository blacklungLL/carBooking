import React from 'react';

const Confirmation = () => {
  return (
    <div className="container mt-4 mb-4">
      <div className="card p-4">
        <div className="row align-items-center mb-3">
          <div className="col-md-12">
            <h5 className="mb-1">Confirmation</h5>
            <div className='d-flex' style={{justifyContent: 'space-between'}}>
              <p className="small" style={{color: '#90A3BF'}}>We are getting to the end. Just a few clicks and your rental is ready!</p>
              <small className="small" style={{color: '#90A3BF'}}>Step 4 of 4</small>
            </div>
          </div>
        </div>

        <div className="form-check mb-4 rounded-lg p-2" style={{ backgroundColor: '#F6F7F9', border:'1px solid #ddd' }}>
          <input className="form-check-input ml-2" type="checkbox" id="termsCheckbox" style={{ transform: 'scale(1.5)'}}/>
          <label className="form-check-label ml-5" htmlFor="termsCheckbox">
            I agree with sending an Marketing and newsletter emails. No spam, promissed!
          </label>
        </div>

        <div className="form-check mb-4 rounded-lg p-2" style={{ backgroundColor: '#F6F7F9', border:'1px solid #ddd' }}>
          <input className="form-check-input ml-2" type="checkbox" id="termsCheckbox" style={{ transform: 'scale(1.5)'}}/>
          <label className="form-check-label ml-5" htmlFor="termsCheckbox">
            I agree with our terms and conditions and privacy policy.
          </label>
        </div>

        <button type="button" className="btn btn-primary w-25 mb-4">Rent Now</button>

        <img className='mb-3' src='/src/assets/ic-security-safety.png' style={{height: '32px', width: '32px'}}/>

        <div className="d-flex align-items-center mb-2">
          <p className="mb-0">All your data are safe</p>
        </div>

        <p className="text-muted small">We are using the most advanced security to provide you the best experience ever.</p>
      </div>
    </div>
  );
};

export default Confirmation;