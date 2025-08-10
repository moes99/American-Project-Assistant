//Packages
import { HashRouter as Router, Routes, Route } from "react-router-dom";

//Pages

//Router
function AppRouter() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<div>Home Page</div>} />
      </Routes>
    </Router>
  );
}

export default AppRouter;
