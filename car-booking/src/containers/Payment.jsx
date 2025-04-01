import React from "react";
import BillingInfo from "../components/PaymentPage/BillingInfo";
import Confirmation from "../components/PaymentPage/Confirmation";
import PaymentFields from "../components/PaymentPage/PaymentFields";
import RentalInfo from "../components/PaymentPage/RentalInfo";
import RentalSum from "../components/PaymentPage/RentalSum";

const Payment = () => {
    return(
        <>
            <div className="d-flex">
                <div className="left-section">
                    <BillingInfo />
                    <RentalInfo />
                    <PaymentFields />
                    <Confirmation />
                </div>
                <RentalSum />
            </div>

        </>
    )

}
export default Payment;