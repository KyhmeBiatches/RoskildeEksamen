import React from 'react'
import ReactDOM from 'react-dom'

class CommentForm extends React.Component {
    render() {
        
        return ( 
            <div className="panel panel-default clearfix">
                <form id="createForm" onSubmit={this._handleClick.bind(this)}>
                        <h3>Skriv til sælger</h3>
                        <div>
                            <input type="text" className="form-control" placeholder="Besked" ref={(input) => this.comment = input}></input>
                        </div>
                        <input className="btn btn-primary create-comment-btn pull-right" type="submit" value="Send"/>
                </form>
            </div>)
    }
    
    _handleClick(e) {
        e.preventDefault();
        let comment = this.comment;
        
        this.props.addComment(comment.value);
    }

}

module.exports = CommentForm;