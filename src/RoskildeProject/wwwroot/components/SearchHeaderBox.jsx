import React from 'react'
import ReactDOM from 'react-dom'

class SearchHeaderBox extends React.Component {
    
    render() {
        return(
            <div>
                <SuggestionList/>
                    <hr></hr>
                <div className="clearfix">
                    <AddCreatorTabs />
                    <SortBox />
                </div>
                <p >Annoncer (120)</p>
                <hr></hr>
                <ListHeader/>
            <hr></hr>
        </div>
        );
    }
    
}

module.exports = SearchHeaderBox;
window.SearchHeaderBox = SearchHeaderBox;