import { MDBCard, MDBCardBody } from "mdb-react-ui-kit";
import { useEffect, useState } from "react";
import { NavLink, useParams } from "react-router-dom";


export function OrderPage(){
    const {id} = useParams()
    const [isLoading, setIsLoading] = useState(true)
    const [order, setOrder] = useState(null)
    async function fetchOrder(id){
        setIsLoading(true)
        const res = await fetch(`/api/orders/${id}`)
        if(res.ok){
            setOrder(await res.json())
        }
        setIsLoading(false)
    }
    useEffect(()=>{
        fetchOrder(id)
    },[id])
    return <>
     <NavLink to="/orders/">Вернуться к заказам</NavLink>
        {isLoading && <p>Загрузка...</p>}

        {order && !isLoading && 
       
        <MDBCard>
                    <MDBCardBody>
                        <h4>Номер заказа: {order.userFriendlyId}</h4>
                        <h5>Отправитель</h5>
                        <p>Город: {order.cityFrom}</p>
                        <p>Адрес: {order.addressFrom}</p>
                        <h5>Получатель</h5>
                        <p>Город: {order.cityTo}</p>
                        <p>Адрес: {order.addressTo}</p>
                        <p>Вес груза: {order.cargoWeight} кг.</p>
                        <p className="fw-bold">Дата отправки: {order.pickupDate}</p>
                    </MDBCardBody>
                    
        </MDBCard>}
    </>
}