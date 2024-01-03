import Header from "./components/Header"
import HomeSearchBar from "./components/HomeSearchBar";
import MovieForm from "./components/MovieForm"
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";




const App = () => {
  return (
    <Router>
      <Header/>
      <Routes>
        <Route path="/" element={<HomeSearchBar/>}/>
        <Route path="/movieForm" element={<MovieForm/>}/>
        {/* <Route path="/game" element={<Game/>}/> */}
      </Routes>
    </Router>
  )
}

export default App;
