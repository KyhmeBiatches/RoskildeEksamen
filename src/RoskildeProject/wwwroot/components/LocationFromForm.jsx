import React from 'react'
import ReactDOM from 'react-dom'

class LocationFromForm extends React.Component {
    
    render() {
        return (
            <form className="form-group clearfix">
                <div className="col-md-5 form-input">
                <input type="text" placeholder="km" className="form-control"></input>
                </div>
                <div className="col-md-2">
                <p className="text-center">fra</p>
                </div>
                <div className="col-md-5 form-input">
                <input type="text" placeholder="9000" className="form-control"></input>
                </div>
                <div className="col-md-12 form-input">
                <input className="btn btn-primary form-control locaiton-btn" type="submit" value="Søg"></input>
                </div>
            </form>
        );
    }
    
}

module.exports = LocationFromForm;
window.LocationFromForm = LocationFromForm;