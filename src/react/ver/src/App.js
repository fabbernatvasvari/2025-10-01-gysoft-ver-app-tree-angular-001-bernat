import logo from "./logo.svg";
import "./App.css";
import DisplayData from "./components/Api";

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <h1> Vasvári Tanár Értekelő Rendszer</h1>
        <p>The app is running. 🎉</p>
        <h5>Üdvözlünk {}!</h5>
        <p>A tanárok száma: <DisplayData /> fő</p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;
