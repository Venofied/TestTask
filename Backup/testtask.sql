PGDMP                         y            testtask    10.17    13.3 
    �
           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �
           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �
           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �
           1262    18853    testtask    DATABASE     e   CREATE DATABASE testtask WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Russian_Russia.1251';
    DROP DATABASE testtask;
                postgres    false            �            1259    18879 
   Department    TABLE     L   CREATE TABLE public."Department" (
    id bigint NOT NULL,
    name text
);
     DROP TABLE public."Department";
       public            postgres    false            �            1259    18854    Employee    TABLE     �   CREATE TABLE public."Employee" (
    id bigint NOT NULL,
    name text,
    salary bigint,
    name_department text,
    id_department bigint DEFAULT 0 NOT NULL
);
    DROP TABLE public."Employee";
       public            postgres    false            �
          0    18879 
   Department 
   TABLE DATA           0   COPY public."Department" (id, name) FROM stdin;
    public          postgres    false    197   	       �
          0    18854    Employee 
   TABLE DATA           V   COPY public."Employee" (id, name, salary, name_department, id_department) FROM stdin;
    public          postgres    false    196   �	       v
           2606    18886    Department Department_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public."Department"
    ADD CONSTRAINT "Department_pkey" PRIMARY KEY (id);
 H   ALTER TABLE ONLY public."Department" DROP CONSTRAINT "Department_pkey";
       public            postgres    false    197            t
           2606    18878    Employee Primary_key_id 
   CONSTRAINT     Y   ALTER TABLE ONLY public."Employee"
    ADD CONSTRAINT "Primary_key_id" PRIMARY KEY (id);
 E   ALTER TABLE ONLY public."Employee" DROP CONSTRAINT "Primary_key_id";
       public            postgres    false    196            �
   "   x�3�0�bӅ-�^ح`�e��5����� M*�      �
   �   x�e���@E��)n����Y�	2����#h���a��P����~��?�끓��G�"J�Rϵ���WP$)�\��4�n�^y��{q�K�/J^8ծ�י�St�~�ڝcl����'g.�Cd�ߨ�QD��^X�     