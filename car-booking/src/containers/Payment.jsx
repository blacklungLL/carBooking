import React, { useState, useEffect } from "react";
import BillingInfo from "../components/PaymentPage/BillingInfo";
import Confirmation from "../components/PaymentPage/Confirmation";
import PaymentFields from "../components/PaymentPage/PaymentFields";
import RentalInfo from "../components/PaymentPage/RentalInfo";
import RentalSum from "../components/PaymentPage/RentalSum";
import { useParams } from 'react-router-dom';
import { FormProvider } from "../components/PaymentPage/FormContext";

const Payment = () => {
    const [cardOfCar, setCars] = useState([]);
    const { id } = useParams();

    useEffect(() => {
        fetch(`http://79.137.192.67:9999/api/Cars/${id}`)
            .then((response) => response.json())
            .then((data) => setCars(data))
            .catch((error) => console.error("Ошибка при загрузке данных:", error));
    }, [id]);

    const carId = parseInt(id, 10);
    const car = cardOfCar && cardOfCar.id === carId ? cardOfCar : null;
  
    if (!car) {
      return <div>Car not found</div>;
    }

    return(
        <>
            <div className="d-flex">
                <FormProvider>
                    <div className="left-section">
                        <BillingInfo />
                        <RentalInfo />
                        <PaymentFields />
                        <Confirmation />
                    </div>
                </FormProvider>
                <RentalSum car={car}/>
            </div>

        </>
    )

}
export default Payment;