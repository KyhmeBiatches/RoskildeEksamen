import React from 'react'
import ReactDOM from 'react-dom'

class PriceForm extends React.Component {
    
    render() {
        return (
            <form className="form-group clearfix">
                <div className="form-input col-md-7">
                    <input type="text" placeholder="kr" className="form-control"></input>
                </div>
                <div className="col-md-5">
                    <input className="btn btn-primary form-control" type="submit" value="Vis"></input>
                </div>
                
            </form>
        );
    }
    
}

module.exports = PriceForm;
window.PriceForm = PriceForm;