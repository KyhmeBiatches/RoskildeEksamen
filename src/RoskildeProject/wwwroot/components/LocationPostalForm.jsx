import React from 'react'
import ReactDOM from 'react-dom'

class LocationPostalForm extends React.Component {
    
    render() {
        return (
            <form className="form-group clearfix">
                <div className="col-md-8 form-input">
                <input type="text" placeholder="Postnr." className="form-control"></input>
                </div>
                <div className="col-md-4 form-input">
                    <input className="btn btn-primary form-control" type="submit" value="Vis"></input>
                </div>
            </form>
        );
    }
    
}

module.exports = LocationPostalForm;
window.LocationPostalForm = LocationPostalForm;