
import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import NavBar from './components/NavBar'
import { Route, Routes } from 'react-router-dom'
import { RoutesNames } from './constants'

import Pocetna from './pages/Pocetna'

import Smjerovi from './pages/smjerovi/Smjerovi'
import SmjeroviDodaj from './pages/smjerovi/SmjeroviDodaj'
import SmjeroviPromjena from './pages/smjerovi/SmjeroviPromjena'


import Predavaci from "./pages/predavaci/Predavaci"
import PredavaciDodaj from "./pages/predavaci/PredavaciDodaj"
import PredavaciPromjena from "./pages/predavaci/PredavaciPromjena"

import Polaznici from "./pages/polaznici/Polaznici"
import PolazniciDodaj from "./pages/polaznici/PolazniciDodaj"
import PolazniciPromjena from "./pages/polaznici/PolazniciPromjena"

import Grupe from "./pages/grupe/Grupe"
import GrupeDodaj from "./pages/grupe/GrupeDodaj"
import GrupePromjena from "./pages/grupe/GrupePromjena"


function App() {


  return (
    <>
      <NavBar />
      <Routes>
        <Route path={RoutesNames.HOME} element={<Pocetna />} />

        <Route path={RoutesNames.SMJER_PREGLED} element={<Smjerovi />} />
        <Route path={RoutesNames.SMJER_NOVI} element={<SmjeroviDodaj />} />
        <Route path={RoutesNames.SMJER_PROMJENA} element={<SmjeroviPromjena />} />

        <Route path={RoutesNames.PREDAVAC_PREGLED} element={<Predavaci />} />
        <Route path={RoutesNames.PREDAVAC_NOVI} element={<PredavaciDodaj />} />
        <Route path={RoutesNames.PREDAVAC_PROMJENA} element={<PredavaciPromjena />} />

        <Route path={RoutesNames.POLAZNIK_PREGLED} element={<Polaznici />} />
        <Route path={RoutesNames.POLAZNIK_NOVI} element={<PolazniciDodaj />} />
        <Route path={RoutesNames.POLAZNIK_PROMJENA} element={<PolazniciPromjena />} />

        <Route path={RoutesNames.GRUPA_PREGLED} element={<Grupe />} />
        <Route path={RoutesNames.GRUPA_NOVI} element={<GrupeDodaj />} />
        <Route path={RoutesNames.GRUPA_PROMJENA} element={<GrupePromjena />} />
        
      </Routes>
    </>
  )
}

export default App
