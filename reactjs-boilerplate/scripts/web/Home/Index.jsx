var HelloWorldComponent = React.createClass({
  render: function() {
    return (
      <h2>
          Hello World!
      </h2>
    );
  }
});

// IMPORTANT: this should be commented/removed when using server-side rendering
/*
if (typeof window !== "undefined") {
    ReactDOM.render(
        <HelloWorldComponent />,
        document.getElementById("mainContent"));
};
*/