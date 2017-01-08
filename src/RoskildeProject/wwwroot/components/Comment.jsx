import React from 'react'
import ReactDOM from 'react-dom'

class Comment extends React.Component {
    render() {
        return (
                <div className="panel panel-default clearfix">
                    <div className=""> 
                       <strong> {this.props.created_at} </strong>
                    </div>
                <hr></hr>
                    <div>
                        <p>{this.props.comment}</p>
                    </div>
                    <div className="pull-right">  
                        <em>Bruger: {this.props.author}</em> 
                    </div>
                </div>
               )
    }
}

module.exports = Comment;
