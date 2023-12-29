import { Link } from "react-router-dom"

const Header = () => {
    return (
        <div id="navBar">
            <h1 id="headerTitle">Title of Movie App</h1>
            <button id="menuButton"><img id="menuImage" src="img/menu.png" alt="menu icon"/></button>
        </div>
    )
}

export default Header;