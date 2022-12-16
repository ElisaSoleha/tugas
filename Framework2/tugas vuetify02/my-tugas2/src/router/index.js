import Vue from 'vue'
import VueRouter from 'vue-router'
import WebHome from '../components/WebHome.vue'
import WebLogin from '../components/WebLogin.vue'
import AboutView from '../views/AboutView.vue'

Vue.use(VueRouter)

const routes = [
 
  {
    path:'/home',
    component: WebHome
  },
  {
    path: '/about',
    component: AboutView
  },
  {
    path: '/login',
    component: WebLogin
  }
]

const router = new VueRouter({
 
  routes
})

export default router
