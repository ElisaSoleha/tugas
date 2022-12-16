<template>
    <v-container>
        <v-form v-model="valid">
            <v-text-field
            v-model="name"
            :rules="nameRules"
            :counter="10"
            label="Name"
            requered
            ></v-text-field>
            <v-text-field
            v-model="email"
            :rules="emailRules"
            label="E-mail"
            requered
            ></v-text-field>
            <v-text-field
            v-model="pesan"
            :rules="pesanRules"
            label="Pesan"
            requered
            ></v-text-field>
        </v-form>
    </v-container>
</template>
<script>
    export default{
        data:() => ({
            valid:false,
            name:'',
            nameRules:[
                v => !!v || 'Name is required',
                v => v.length <= 10 || 'Name must be less than 10 characters'
            ],
            email:'',
            emailRules:[
                v => !!v || 'E-mail is required',
                v => /.+@.+/.test(v) || 'E-mail must be valid'
            ],
            pesan:''
        }),
    }
</script>