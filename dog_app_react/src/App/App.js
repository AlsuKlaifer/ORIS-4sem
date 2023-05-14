import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';
import Dogs from '../Components/Dogs';
import TopMenu from '../Components/Header';
import {Route, Routes} from 'react-router-dom';
import About from '../Components/About';

function App() {
  return (
    <Routes>
      <Route path='/' element={<> <TopMenu/> <Dogs/> </>} />
      <Route path='/:id' element={<> <TopMenu/> <About/> </>} />
    </Routes>
  );
}

export default App;
