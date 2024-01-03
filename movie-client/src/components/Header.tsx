import { Link } from "react-router-dom"
import {useState} from "react";

const Header = () => {
    const [dropDownIsClicked, setDropDownIsClicked] = useState(false);

    const handleDropDownClick = () => {
        setDropDownIsClicked(!dropDownIsClicked);
    }

    return (
        <div id="navBar">
            <h1 id="headerTitle">Title of Movie App</h1>
            <div className="dropDown">
                <button onClick={handleDropDownClick} id="menuButton"><img id="menuImage" src={dropDownIsClicked ? "img/icons/x.png":"img/icons/menu.png"} alt="menu icon"/></button>
                <div className="dropDown-options">
                    <Link className="dropDown-links" to="/movieForm">Add Movie</Link>
                </div>
            </div>
        </div>
    )
}

export default Header;