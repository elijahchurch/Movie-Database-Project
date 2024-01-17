const MovieForm = () => {
    return(
        <div>
            <form className="formContainer">
                <h1> Movie Entry</h1>
                <label htmlFor="movieName">Name</label>
                <input id="movieName" name="movieName" type="text"></input>
                <label htmlFor="movieYear">Release Year</label>
                <input id="movieYear" type="number" min="1888" max="2024" name="movieYear"></input>
                <label htmlFor="rating">Rating</label>
                <select name="rating">
                    <option value="G">G</option>
                    <option value="PG">PG</option>
                    <option value="PG-13">PG-13</option>
                    <option value="R">R</option>
                    <option value="NR">NR</option>
                </select>
                <label htmlFor="movieLength"> Run Time</label>
                <input name="movieLength" type="number" min="0"></input>
                <label htmlFor="overView">Synopsis</label>
                <textarea></textarea>
                <button type="submit">Submit</button>
            </form>
        </div>
    )
}

export default MovieForm