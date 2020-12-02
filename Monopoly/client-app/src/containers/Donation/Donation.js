import React, { useCallback, useEffect, useState } from 'react'
import classes from './Donation.css'
import {useLiqPay} from './../../hooks/liqPay.hook'

const Donation = () => {
    const [liqPayForm, setLiqPayForm] = useState()
    const [form, setForm] = useState({
        amount: '', currency: 'uah', description: 'Donation', order_id: '12313222'
    })
    const {getLiqPay} = useLiqPay();
    const renderButton = useCallback(() => {
        form.amount = parseFloat(form.amount)
        getLiqPay({...form}).then((result) => {
            setLiqPayForm(
                <form method="POST" action="https://www.liqpay.ua/api/3/checkout">
                    <input type="hidden" name="data" value={result.data}/>
                    <input type="hidden" name="signature" value={result.signature}/>
                    <input type="submit" src="//static.liqpay.ua/buttons/p1ru.radius.png"/>
                </form>
            )
        })
    },[form, getLiqPay])
    useEffect(() => {
        if(form.amount == null || form.amount===''){
            setLiqPayForm(null)
        }
        else{
            renderButton()
        }
    }, [form.amount, renderButton])
    const changeHandler = event => {
        setForm(prev =>{return{...prev, [event.target.name]: event.target.value}})
    }

    return (
        <div className={classes.Donation}> 
            <h1>Donation</h1>
            <form>
                <div className="form-group">
                    <label>Amount</label>
                    <input onChange={changeHandler} type="number" name="amount" placeholder="Enter amount" />
                </div>
            </form> 
            {
                liqPayForm
            } 
        </div>
    )
}

export default Donation
