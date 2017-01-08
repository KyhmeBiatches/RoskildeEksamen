import React from 'react'
import ReactDOM from 'react-dom'
var CommentForm = require('./CommentForm.jsx');
var Comment = require('./Comment.jsx');

class CommentBox extends React.Component {

    constructor(atts) {
        super(atts);
        
        this.state = ({comments: [], commentCount: 0});   
    }
    
    render () {
        return <div>
                    <h3>Beskeder</h3>
                    <CommentForm addComment={this._addComment.bind(this)} />
                   {this._getComments()}
                </div>
    }
    
    componentWillUnmount() {
    alert('ComponentWillMount');
    }
    
    _getComments() {
        return this.state.comments.map((comment) => {
            return (
                <Comment 
                    author={comment.author}
                    comment={comment.comment}
                    created_at={comment.created_at}
                    key={comment.id}
                />
            );
        });
    }
    
    _addComment(comment) {
        const element = {id: this.state.comments.length +1,
                         author: "Marck Jensen",
                         created_at: "6. november kl. 19.38",
                         comment: comment}
        this.setState({ comments: this.state.comments.concat([element]), commentCount: this.state.comments.length +1})
    }
    
}

ReactDOM.render(
  <CommentBox />,
  document.getElementById('comment-box')
);
module.exports = CommentBox;
    
