import React from 'react'
import ReactDOM from 'react-dom'

class SearchElement extends React.Component {

    render() {
        var imagePath = "items/Details/" + this.props.id;
        return(
            <div className="" >
                <a href={imagePath}>
                <span>
                    <img className="mainpageImg" src={this.props.picture} alt=""></img>
                    <h5 className="col-md-6">{this.props.title}</h5>
                </span>
                </a>
            </div>
        );
    }
    
}

window.SearchElement = SearchElement;
module.exports = SearchElement;