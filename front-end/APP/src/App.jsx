import { BrowserRouter, Route, Routes } from "react-router-dom";

import Home from "./pages/Homapage/Home.jsx";
import About from "./pages/About/About.jsx";
import PageNotFound from "./components/PageNotFound.jsx";

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="about" element={<About />} />
        <Route path="*" element={<PageNotFound />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
