import React from 'react'
import ReactDOM from 'react-dom'

class SuggestionBox extends React.Component {
    render(){
        return(
        <div>
            <SuggestionList />
        </div>
        )
    }
}

module.exports = SuggestionBox;
window.SuggestionBox = SuggestionBox;
