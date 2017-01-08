import React from 'react'
import ReactDOM from 'react-dom'

var TutorialBox = React.createClass({
    render: function() {
        return (
          <div className="tutorialBox">
            Det virker sq.
          </div>
      );
    }
});
ReactDOM.render(
  <TutorialBox />,
  document.getElementById('tutorial')
);

module.exports = TutorialBox;