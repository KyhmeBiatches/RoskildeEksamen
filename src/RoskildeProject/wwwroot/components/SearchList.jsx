import React from 'react'
import ReactDOM from 'react-dom'

class SearchList extends React.Component {
    
    render() {
        return (
            <div>
            <SearchPager />
            </div>
        );
    }
    
}

module.exports = SearchList;
window.SearchList = SearchList;