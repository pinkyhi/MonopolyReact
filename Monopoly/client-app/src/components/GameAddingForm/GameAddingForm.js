import React, { useState } from 'react'
import classes from './GameAddingForm.css'

function DrawCapacityDivs(){
    var resultArray = []
    for(let i = 2; i < 7; i++){
        resultArray.push(
            <div className={classes.CapacityDiv} value={i}>
                {i}
            </div>
        )
    }
    return resultArray
}

const GameAddingForm = () => {
    const [form, setForm] = useState({title: '', password: '', capacity: ''});
    const changeHandler = event => {
        setForm(prev =>{return{...prev, [event.target.name]: event.target.value}})
    }
    return(
        <div className={classes.GameAddingForm}>
        <h1>Add new game</h1>
        <input type="text" onChange={changeHandler} name="title" placeholder="Title" value='' />
        <input type="text" onChange={changeHandler} name="password" placeholder="Password" />
        <div className={classes.Capacity}>{DrawCapacityDivs()}</div>
    </div>
    )
}

export default GameAddingForm