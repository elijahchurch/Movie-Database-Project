import React, {MouseEvent, ChangeEvent, useState} from "react";

const MovieForm = () => {
    const [movieName, setMovieName] = useState("");
    const [movieYear, setMovieYear] = useState("");
    const [rating, setRating] = useState("");
    const [movieLength, setMovieLength] = useState("");
    const [overView, setOverView] = useState("");

    const handleChange = (event : React.FormEvent<HTMLInputElement | HTMLTextAreaElement | HTMLSelectElement>) => {
        event.preventDefault;
        switch (event.currentTarget.name) {
            case "movieName":
                setMovieName(event.currentTarget.value);
                break;
            case "movieYear":
                setMovieYear(event.currentTarget.value);
                break;
            case "rating":
                setRating(event.currentTarget.value);
                break;
            case "movieLength":
                setMovieLength(event.currentTarget.value);
                break;
            case "overView":
                setOverView(event.currentTarget.value);
                break;
        }
    }

    const handleMovieForm = async (event : MouseEvent) => {
        event?.preventDefault();
        console.log(event);
    }
    return(
        <div>
            <form className="formContainer">
                <h2> Movie Entry</h2>
                <label htmlFor="movieName">Name</label>
                <input 
                    name="movieName"
                    type="text"
                    onChange={handleChange}
                />
                <label htmlFor="movieYear">Release Year</label>
                <input 
                    name="movieYear"
                    type="number"
                    min="1888"
                    max="2024"
                    onChange={handleChange}
                />
                <label htmlFor="rating">Rating</label>
                <select name="rating" onChange={handleChange}>
                    <option value="G">G</option>
                    <option value="PG">PG</option>
                    <option value="PG-13">PG-13</option>
                    <option value="R">R</option>
                    <option value="NR">NR</option>
                </select>
                <label htmlFor="movieLength"> Run Time</label>
                <input 
                    name="movieLength"
                    type="number"
                    min="0"
                    onChange={handleChange}
                />
                <label htmlFor="overView">Synopsis</label>
                <textarea name="overView" onChange={handleChange}></textarea>
                <button onClick={handleMovieForm} type="submit">Submit</button>
            </form>
        </div>
    )
}

export default MovieForm