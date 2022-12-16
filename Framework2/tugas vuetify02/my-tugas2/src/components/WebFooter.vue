<template>
    <section>
    <v-footer id="footer" app bottom absolute paddless dark>
    <v-card class="flex" flat tile>
    <v-card-title class="teal">
        <strong class="subheading">Get connected with us on social networks!</strong>
        <v-spacer></v-spacer>
        <v-icon size="24px" left>mdi-facebook</v-icon>
        <v-icon size="24px" left>mdi-twitter</v-icon>
        <v-icon size="24px" left>mdi-instagram</v-icon>
        <v-icon size="24px" left>mdi-google-plus</v-icon>
        <v-icon size="24px" left>mdi-linkedin</v-icon>
    </v-card-title>

    <v-card-actions id="copyright">
        <p>@{{ new Date() .getFullYear()}} - <strong>Universitas Riau</strong></p>
    </v-card-actions>
    </v-card>
   </v-footer>
</section>
</template>

<style>
#copyright { 
    justify-content: center;
}
#footer .teal{
    background-color: darkgreen !important;
}
</style>